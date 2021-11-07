// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.BackRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Provides event data for the SystemNavigationManager.BackRequested event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class BackRequestedEventArgs : IBackRequestedEventArgs
  {
    /// <summary>Gets or sets a value that indicates whether the app performed the requested back-navigation.</summary>
    /// <returns>**true** if the app performed the requested back-navigation; otherwise, **false**. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
