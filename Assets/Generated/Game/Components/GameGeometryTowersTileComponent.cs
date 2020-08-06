//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public GeometryTowers.TileComponent geometryTowersTile { get { return (GeometryTowers.TileComponent)GetComponent(GameComponentsLookup.GeometryTowersTile); } }
    public bool hasGeometryTowersTile { get { return HasComponent(GameComponentsLookup.GeometryTowersTile); } }

    public void AddGeometryTowersTile(GeometryTowers.Map.Tile.GameTileType newType) {
        var index = GameComponentsLookup.GeometryTowersTile;
        var component = (GeometryTowers.TileComponent)CreateComponent(index, typeof(GeometryTowers.TileComponent));
        component.Type = newType;
        AddComponent(index, component);
    }

    public void ReplaceGeometryTowersTile(GeometryTowers.Map.Tile.GameTileType newType) {
        var index = GameComponentsLookup.GeometryTowersTile;
        var component = (GeometryTowers.TileComponent)CreateComponent(index, typeof(GeometryTowers.TileComponent));
        component.Type = newType;
        ReplaceComponent(index, component);
    }

    public void RemoveGeometryTowersTile() {
        RemoveComponent(GameComponentsLookup.GeometryTowersTile);
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

    static Entitas.IMatcher<GameEntity> _matcherGeometryTowersTile;

    public static Entitas.IMatcher<GameEntity> GeometryTowersTile {
        get {
            if (_matcherGeometryTowersTile == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GeometryTowersTile);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGeometryTowersTile = matcher;
            }

            return _matcherGeometryTowersTile;
        }
    }
}