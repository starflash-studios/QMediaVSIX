// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.Preview.ISystemNavigationCloseRequestedPreviewEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core.Preview
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SystemNavigationCloseRequestedPreviewEventArgs))]
  [Guid(2211450337, 52197, 20273, 132, 20, 54, 29, 160, 70, 81, 143)]
  internal interface ISystemNavigationCloseRequestedPreviewEventArgs
  {
    bool Handled { get; set; }

    Deferral GetDeferral();
  }
}
