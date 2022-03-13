using ApiResume.Domain.Enums;
using ApiResume.Domain.Models;
using ApiResume.Domain.Repository.Interfaces;
using ApiResume.Domain.Responses;
using ApiResume.Services.Interfaces.Stacks;
using ApiResume.Services.Stacks;
using ApiResumeTest.Fakes;
using AutoMapper;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ApiResumeTest.Services.Stacks
{
    public class StackServiceTests
    {
        private readonly Mock<IMapper> _mapper;
        private readonly Mock<IStackRepository> _stackRepository;
        private readonly IStackService _stackService;

        public StackServiceTests()
        {
            _mapper = new Mock<IMapper>();
            _stackRepository = new Mock<IStackRepository>();
            _stackService = new StackService(_mapper.Object, _stackRepository.Object);
        }

        [Fact]
        public async Task ShouldReturnSuccess_WhenService_GetStackById()
        {
            // Arrange
            var stackId = StackIds.BackEndFrameworks;
            Stack stack = StackFake.GetStackById(stackId);
            var stackResponse = new StackResponse { StackId = stack.StackId, StackName = stack.StackName };

            _stackRepository.Setup(m => m.GetStackByStackId(It.IsAny<StackIds>())).Returns(Task.FromResult(stack));
            _mapper.Setup(m => m.Map<StackResponse>(stack)).Returns(stackResponse);

            // Act
            StackResponse result = await _stackService.GetStackByStackId(stackId);

            // Assert 
            Assert.NotNull(result);
            Assert.Equal(stack.StackId, result.StackId);
            Assert.Equal(stack.StackName, result.StackName);
        }

        [Fact]
        public async Task ShouldReturnSuccess_WhenService_GetAllStacks()
        {
            // Arrange
            IEnumerable<Stack> stacks = StackFake.GetStacks();
            IEnumerable<StackResponse> stackResponses = stacks.Select(stack =>
            {
                return new StackResponse { StackId = stack.StackId, StackName = stack.StackName };
            });

            _stackRepository.Setup(m => m.GetAll()).Returns(Task.FromResult(stacks));
            _mapper.Setup(m => m.Map<IEnumerable<StackResponse>>(It.IsAny<IEnumerable<Stack>>())).Returns(stackResponses);

            // Act
            IEnumerable<StackResponse> result = await _stackService.GetAll();

            // Assert 
            Assert.NotEmpty(result);
            Assert.Equal(result.Count(), stackResponses.Count());
        }
    }
}
