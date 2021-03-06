//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public CurrentTurnNodeComponent currentTurnNode { get { return (CurrentTurnNodeComponent)GetComponent(ComponentIds.CurrentTurnNode); } }

        public bool hasCurrentTurnNode { get { return HasComponent(ComponentIds.CurrentTurnNode); } }

        public Entity AddCurrentTurnNode(System.Collections.Generic.LinkedListNode<Entitas.Entity> newValue) {
            var component = CreateComponent<CurrentTurnNodeComponent>(ComponentIds.CurrentTurnNode);
            component.value = newValue;
            return AddComponent(ComponentIds.CurrentTurnNode, component);
        }

        public Entity ReplaceCurrentTurnNode(System.Collections.Generic.LinkedListNode<Entitas.Entity> newValue) {
            var component = CreateComponent<CurrentTurnNodeComponent>(ComponentIds.CurrentTurnNode);
            component.value = newValue;
            ReplaceComponent(ComponentIds.CurrentTurnNode, component);
            return this;
        }

        public Entity RemoveCurrentTurnNode() {
            return RemoveComponent(ComponentIds.CurrentTurnNode);
        }
    }

    public partial class Pool {
        public Entity currentTurnNodeEntity { get { return GetGroup(Matcher.CurrentTurnNode).GetSingleEntity(); } }

        public CurrentTurnNodeComponent currentTurnNode { get { return currentTurnNodeEntity.currentTurnNode; } }

        public bool hasCurrentTurnNode { get { return currentTurnNodeEntity != null; } }

        public Entity SetCurrentTurnNode(System.Collections.Generic.LinkedListNode<Entitas.Entity> newValue) {
            if (hasCurrentTurnNode) {
                throw new EntitasException("Could not set currentTurnNode!\n" + this + " already has an entity with CurrentTurnNodeComponent!",
                    "You should check if the pool already has a currentTurnNodeEntity before setting it or use pool.ReplaceCurrentTurnNode().");
            }
            var entity = CreateEntity();
            entity.AddCurrentTurnNode(newValue);
            return entity;
        }

        public Entity ReplaceCurrentTurnNode(System.Collections.Generic.LinkedListNode<Entitas.Entity> newValue) {
            var entity = currentTurnNodeEntity;
            if (entity == null) {
                entity = SetCurrentTurnNode(newValue);
            } else {
                entity.ReplaceCurrentTurnNode(newValue);
            }

            return entity;
        }

        public void RemoveCurrentTurnNode() {
            DestroyEntity(currentTurnNodeEntity);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherCurrentTurnNode;

        public static IMatcher CurrentTurnNode {
            get {
                if (_matcherCurrentTurnNode == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.CurrentTurnNode);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherCurrentTurnNode = matcher;
                }

                return _matcherCurrentTurnNode;
            }
        }
    }
}
