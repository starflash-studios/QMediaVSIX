// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkSynchronizer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2610864480, 44699, 17913, 132, 7, 75, 73, 59, 22, 54, 97)]
  [ExclusiveTo(typeof (InkSynchronizer))]
  internal interface IInkSynchronizer
  {
    IVectorView<InkStroke> BeginDry();

    void EndDry();
  }
}
