using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestTask.Business.ServicesImplementation;
using TestTask.Core.Abstractions;
using TestTask.Models;

namespace TestTask.Controllers
{
    /// <summary>
    /// Orders controller.
    /// DO NOT change anything here. Use created contract and provide only needed implementation.
    /// </summary>
    [Route("api/v1/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrdersController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        /// <summary>
        /// Returns selected order.
        /// Selection rules are specified in Task description provided by recruiter
        /// </summary>
        [HttpGet]
        [Route("get-order-with-max-price")]
        public async Task<IActionResult> GetOrderWithMaxPrice()
        {
            var order = await _orderService.GetOrderWithMaxPrice();

            var orderModel = _mapper.Map<OrderModel>(order);

            return Ok(orderModel);
        }

        /// <summary>
        /// Returns list of selected orders. 
        /// Selection rules are specified in Task description provided by recruiter
        /// </summary>
        [HttpGet]
        [Route("get-all-orders-with-number-of-products-more-then-ten")]
        public async Task<IActionResult> GetAllOrdersWithNumberOfProductsMoreThenTen()
        {
            var orderList = await _orderService.GetAllOrdersWithNumberOfProductsMoreThenTen();

            var orderModelList = new List<OrderModel>();

            foreach (var order in orderList)
            {
                orderModelList.Add(_mapper.Map<OrderModel>(order));
            }

            return Ok(orderModelList);
        }
    }
}
