// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ItemIndexRange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Provides info about a range of items in the data source.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IItemIndexRangeFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class ItemIndexRange : IItemIndexRange
  {
    /// <summary>Initializes an instance of the ItemIndexRange class.</summary>
    /// <param name="firstIndex">The index of the first item in the instance of the ItemIndexRange class.</param>
    /// <param name="length">The number of items in the instance of the ItemIndexRange class.</param>
    [MethodImpl]
    public extern ItemIndexRange(int firstIndex, uint length);

    /// <summary>Gets the index of the first item in the instance of the ItemIndexRange class.</summary>
    /// <returns>The index of the first item in the instance of the ItemIndexRange class.</returns>
    public extern int FirstIndex { [MethodImpl] get; }

    /// <summary>Gets the number of items in the instance of the ItemIndexRange class.</summary>
    /// <returns>The number of items in the instance of the ItemIndexRange class.</returns>
    public extern uint Length { [MethodImpl] get; }

    /// <summary>Gets the index of the last item in the instance of the ItemIndexRange class.</summary>
    /// <returns>The index of the last item in the instance of the ItemIndexRange class.</returns>
    public extern int LastIndex { [MethodImpl] get; }
  }
}
