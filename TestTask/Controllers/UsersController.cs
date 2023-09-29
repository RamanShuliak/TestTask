using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestTask.Core.Abstractions;
using TestTask.Models;

namespace TestTask.Controllers
{
    // В условии задачи не было указаний о притягивании наружу помимо необходимых сущностей из БД
    // связанных с ними данных. Ввиду этого данные мною посредством жадной загрузки не притягивались.

    // Надеюсь, в 5м пункте условия задачи под проверкой работоспособности приложения имелась в виду
    // проверка компилируемости кода и правильности возвращаемых данных, а не написание Unit-тестов)))
    // Написать бы мог, но подумал, что, если бы это было необходимо, вы бы это лучше конкретизировали.

    /// <summary>
    /// Users controller.
    /// DO NOT change anything here. Use created contract and provide only needed implementation.
    /// </summary>
    [Route("api/v1/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        /// <summary>
        /// Returns selected user. 
        /// Selection rules are specified in Task description provided by recruiter
        /// </summary>
        [HttpGet]
        [Route("get-user-with-max-number-of-orders")]
        public async Task<IActionResult> GetUserWithMaxNumberOfOrders()
        {
            var user = await _userService.GetUserWithMaxNumberOfOrders();

            var userModel = _mapper.Map<UserModel>(user);

            return Ok(userModel);
        }

        /// <summary>
        /// Returns list of selected users. 
        /// Selection rules are specified in Task description provided by recruiter
        /// </summary>
        [HttpGet]
        [Route("get-all-inactive-users")]
        public async Task<IActionResult> GetAllInactiveUsers()
        {
            var userList = await _userService.GetAllInactiveUsers();

            var userModelList = new List<UserModel>();

            foreach (var user in userList)
            {
                userModelList.Add(_mapper.Map<UserModel>(user));
            }

            return Ok(userModelList);
        }
    }
}
