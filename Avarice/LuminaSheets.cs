using Dalamud.Game.ClientState.Objects.Types;
using Lumina.Excel.Sheets;

namespace Avarice;

internal static class LuminaSheets
{
    internal static uint[] NonPositionalUnits;

    internal static void Init()
    {
        NonPositionalUnits = Svc.Data.GetExcelSheet<BNpcBase>()!.Where(x => x.IsOmnidirectional).Select(x => x.RowId).ToArray();
    }

    public static bool HasPositional(this IGameObject obj)
    {
        return !NonPositionalUnits.Contains(obj.DataId);
    }
}
