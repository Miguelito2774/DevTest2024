using System.Collections;
using api.Application.Dtos;
using api.Application.Repositories;
using api.Application.Responses;
using api.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace api.Presentation;

[ApiController]
[Route("/api/v1/polls")]
public class PollController(IPollRepository pollRepository, IOptionRepository optionRepository): ControllerBase
{
    [HttpGet()]
    public async Task<IResult> GetAllPolls()
    {
        IList<Poll> polls = await pollRepository.GetAll();
        IDictionary<int, List<Option>> options = await optionRepository.GroupOptionsByPoll();

        foreach (var poll in polls)
        {
            if (options.TryGetValue(poll.Id, out List<Option>? pollOptions))
            {
                poll.Options = pollOptions;
            }
        }

        IList<GetAllPollsResponse> response = (IList<GetAllPollsResponse>)polls.Select<Poll, GetAllPollsResponse>(p => new GetAllPollsResponse(p));
        
        return Results.Ok(response);
    }
    
    
    //[HttpPost()]
    //public async Task<IResult> PostPoll([FromBody] CreatePollDto request)
    //{
        
    //}

    //[HttpPost("{optionId:int}/votes")]
    //public async Task<IResult> PostVote(int optionId, [FromBody] CreateVoteDto request)
    //{
        
    //}
}
