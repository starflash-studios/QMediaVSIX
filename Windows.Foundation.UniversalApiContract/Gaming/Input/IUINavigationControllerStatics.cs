// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IUINavigationControllerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (UINavigationController))]
  [Guid(789877514, 63224, 19016, 141, 137, 148, 120, 108, 202, 12, 46)]
  internal interface IUINavigationControllerStatics
  {
    event EventHandler<UINavigationController> UINavigationControllerAdded;

    event EventHandler<UINavigationController> UINavigationControllerRemoved;

    IVectorView<UINavigationController> UINavigationControllers { get; }
  }
}
