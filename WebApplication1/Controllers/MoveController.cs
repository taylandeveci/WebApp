using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoveController : ControllerBase
    {
        private readonly IMoveRepository _moveRepository;

        public MoveController(IMoveRepository moveRepository)
        {
            _moveRepository = moveRepository;
        }

        [HttpGet]
        public IActionResult GetMoves()
        {
            var moves = _moveRepository.GetMoves();
            return Ok(moves);
        }

        [HttpGet("{id}")]
        public IActionResult GetMove(int id)
        {
            var move = _moveRepository.GetMove(id);
            if (move == null)
                return NotFound();
            return Ok(move);
        }

        [HttpPost]
        public IActionResult CreateMove([FromBody] Move move)
        {
            if (move == null)
                return BadRequest();

            var success = _moveRepository.CreateMove(move);
            if (!success)
                return StatusCode(500, "Failed to create move.");

            return Ok("Move created successfully");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMove(int id, [FromBody] Move move)
        {
            if (move == null || move.Id != id)
                return BadRequest();

            var existing = _moveRepository.GetMove(id);
            if (existing == null)
                return NotFound();

            var success = _moveRepository.UpdateMove(move);
            if (!success)
                return StatusCode(500, "Failed to update move.");

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMove(int id)
        {
            var move = _moveRepository.GetMove(id);
            if (move == null)
                return NotFound();

            var success = _moveRepository.DeleteMove(move);
            if (!success)
                return StatusCode(500, "Failed to delete move.");

            return NoContent();
        }
    }
}
