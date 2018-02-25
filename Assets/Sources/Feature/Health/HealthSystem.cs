using System.Collections.Generic;
using Entitas;

public class HealthSystem : ReactiveSystem<GameEntity> {

    public HealthSystem (Contexts contexts) : base(contexts.game) {
        // pass the context of interest to the base constructor
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) {
        return context.CreateCollector(GameMatcher.Health);
    }

    protected override bool Filter(GameEntity entity) {
        return entity.isHealth;
    }

    protected override void Execute(List<GameEntity> entities) {
        foreach (var entity in entities) {
            // do stuff to the matched entities
            
        }
    }
}