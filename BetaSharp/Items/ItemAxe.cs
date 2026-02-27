using BetaSharp.Blocks;

namespace BetaSharp.Items;

public class ItemAxe : ItemTool
{

    private static Block[] blocksEffectiveAgainst =
    [
        Block.Planks,
        Block.Bookshelf,
        Block.Log,
        Block.Chest,
        Block.CraftingTable,
        Block.Fence,
        Block.Door,
        Block.Ladder,
        Block.WoodenStairs,
        Block.Sign,
        Block.WallSign,
        Block.Pumpkin,
        Block.JackLantern,
        Block.WoodenPressurePlate,
        Block.Jukebox,
        Block.Noteblock,
    ];

    public ItemAxe(int id, EnumToolMaterial enumToolMaterial) : base(id, 3, enumToolMaterial, blocksEffectiveAgainst)
    {
    }
}