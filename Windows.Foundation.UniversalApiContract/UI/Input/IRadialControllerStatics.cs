// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (RadialController))]
  [Guid(4208906423, 47180, 18580, 135, 170, 143, 37, 170, 95, 40, 139)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IRadialControllerStatics
  {
    bool IsSupported();

    RadialController CreateForCurrentView();
  }
}
