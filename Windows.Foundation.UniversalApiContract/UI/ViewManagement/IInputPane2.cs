// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IInputPane2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (InputPane))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2322284326, 28816, 18323, 148, 76, 195, 242, 205, 226, 98, 118)]
  internal interface IInputPane2
  {
    bool TryShow();

    bool TryHide();
  }
}
