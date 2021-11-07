// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.PrintCustomItemDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  /// <summary>Allows apps to add a collection of enumerable options to the app print experience.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PrintCustomItemDetails : IPrintCustomItemDetails
  {
    /// <summary>Gets the ID of the custom print task option item.</summary>
    /// <returns>The ID of the print task option.</returns>
    public extern string ItemId { [MethodImpl] get; }

    /// <summary>Gets or sets the display name of the custom print task option item.</summary>
    /// <returns>The display name of the option item.</returns>
    public extern string ItemDisplayName { [MethodImpl] set; [MethodImpl] get; }
  }
}
