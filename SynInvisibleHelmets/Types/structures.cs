using System.Collections.Generic;
using Mutagen.Bethesda.Plugins;
namespace SynInvisibleHelmets.Types;

public class Setting
{
    public int slotToUse = 31;
    public List<ModKey> IgnoreMods = new();
    public List<FormKey> IgnoreItems = new();
}