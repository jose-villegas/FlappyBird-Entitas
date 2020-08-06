//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public GeometryTowers.View.ViewComponent geometryTowersViewView { get { return (GeometryTowers.View.ViewComponent)GetComponent(GameComponentsLookup.GeometryTowersViewView); } }
    public bool hasGeometryTowersViewView { get { return HasComponent(GameComponentsLookup.GeometryTowersViewView); } }

    public void AddGeometryTowersViewView(GeometryTowers.View.IView newValue) {
        var index = GameComponentsLookup.GeometryTowersViewView;
        var component = (GeometryTowers.View.ViewComponent)CreateComponent(index, typeof(GeometryTowers.View.ViewComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGeometryTowersViewView(GeometryTowers.View.IView newValue) {
        var index = GameComponentsLookup.GeometryTowersViewView;
        var component = (GeometryTowers.View.ViewComponent)CreateComponent(index, typeof(GeometryTowers.View.ViewComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGeometryTowersViewView() {
        RemoveComponent(GameComponentsLookup.GeometryTowersViewView);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherGeometryTowersViewView;

    public static Entitas.IMatcher<GameEntity> GeometryTowersViewView {
        get {
            if (_matcherGeometryTowersViewView == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GeometryTowersViewView);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGeometryTowersViewView = matcher;
            }

            return _matcherGeometryTowersViewView;
        }
    }
}