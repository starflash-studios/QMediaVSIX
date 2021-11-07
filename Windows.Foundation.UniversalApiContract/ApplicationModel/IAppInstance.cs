// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IAppInstance
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (AppInstance))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1734290247, 62047, 17714, 159, 214, 54, 51, 224, 99, 77, 1)]
  [WebHostHidden]
  internal interface IAppInstance
  {
    string Key { get; }

    bool IsCurrentInstance { get; }

    void RedirectActivationTo();
  }
}
