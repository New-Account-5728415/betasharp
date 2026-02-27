using BetaSharp.Entities;
using BetaSharp.Worlds;

namespace BetaSharp.Items;

public class ItemSoup : ItemFood
{

    public ItemSoup(int id, int healAmount) : base(id, healAmount, false)
    {
        base.maxCount = 4;
    }

    public override ItemStack use(ItemStack itemStack, World world, EntityPlayer entityPlayer)
    {
        if (itemStack.count > 1)
        {
            return itemStack;
        }
        else
        {
            base.use(itemStack, world, entityPlayer);
            return new ItemStack(Item.Bowl);
        }
    }
}