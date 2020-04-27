using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTodo.Commons;
using WebApiTodo.Dto;
using WebApiTodo.Service;

namespace WebApiTodo.Controllers
{
	[ApiController]
	[Route("orders")]
	public class OrderController : ControllerBase
	{

		private readonly OrderService _orderService;

		public OrderController(OrderService orderService)
		{
			_orderService = orderService;
		}

		[HttpGet]
		public ActionResult<DataCollection<OrderDto>> GetAll(int page, int take = 20)
		{
			return _orderService.GetAll(page, take);
		}

		[HttpGet("{id}")]
		public ActionResult<OrderDto> GetById(int id)
		{
			return _orderService.GetById(id);
		}

		[HttpPost]
		public ActionResult Create(OrderCreateDto model)
		{
			var result = _orderService.Create(model);

			return CreatedAtAction(
				"GetById",
				new { id = result.OrderId },
				result
			);
		}
	}
}