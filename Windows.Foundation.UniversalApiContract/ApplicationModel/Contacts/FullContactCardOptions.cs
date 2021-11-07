// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.FullContactCardOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.ViewManagement;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Specifies the options for displaying the full contact card.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class FullContactCardOptions : IFullContactCardOptions
  {
    /// <summary>Initializes a new instance of the FullContactCardOptions class.</summary>
    [MethodImpl]
    public extern FullContactCardOptions();

    /// <summary>Gets or sets a value that describes the desired view size for the full contact card.</summary>
    /// <returns>A value that describes the desired view size for the full contact card.</returns>
    public extern ViewSizePreference DesiredRemainingView { [MethodImpl] get; [MethodImpl] set; }
  }
}
