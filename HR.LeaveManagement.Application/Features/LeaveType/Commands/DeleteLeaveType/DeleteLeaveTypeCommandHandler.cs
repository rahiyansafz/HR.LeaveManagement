using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Exceptions;

using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.DeleteLeaveType;
public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand, Unit>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;

    public DeleteLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository) => _leaveTypeRepository = leaveTypeRepository;

    public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        // Retrieve to domain entity object
        var leaveTypeToDelete = await _leaveTypeRepository.GetAsync(request.Id) ?? throw new NotFoundException(nameof(LeaveType), request.Id);

        // Remove from database
        await _leaveTypeRepository.DeleteAsync(leaveTypeToDelete);

        // Return Unit value
        return Unit.Value;
    }
}
