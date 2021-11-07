// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreCursor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Defines a cursor (visual pointer) object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ICoreCursorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CoreCursor : ICoreCursor
  {
    /// <summary>Creates a new CoreCursor instance of the provided cursor type.</summary>
    /// <param name="type">The type of the new cursor.</param>
    /// <param name="id">The unique resource ID of the new cursor.</param>
    [MethodImpl]
    public extern CoreCursor(CoreCursorType type, uint id);

    /// <summary>Gets the resource ID of the cursor.</summary>
    /// <returns>The ID of the cursor.</returns>
    public extern uint Id { [MethodImpl] get; }

    /// <summary>Gets the type of the cursor.</summary>
    /// <returns>The type of the cursor.</returns>
    public extern CoreCursorType Type { [MethodImpl] get; }
  }
}
