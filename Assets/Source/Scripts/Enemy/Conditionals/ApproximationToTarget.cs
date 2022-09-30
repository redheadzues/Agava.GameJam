using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class ApproximationToTarget : Conditional
{
    public SharedFloat TargetDistance;
    public SharedEnemyMover EnemyMover;

    public override TaskStatus OnUpdate() 
        => EnemyMover.Value.DistanceToTarget < TargetDistance.Value ? TaskStatus.Success : TaskStatus.Failure;
}