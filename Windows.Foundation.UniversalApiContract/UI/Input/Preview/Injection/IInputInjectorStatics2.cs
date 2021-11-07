// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.IInputInjectorStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (InputInjector))]
  [Guid(2765830395, 56716, 16719, 149, 234, 248, 126, 244, 192, 174, 108)]
  internal interface IInputInjectorStatics2 : IInputInjectorStatics
  {
    InputInjector TryCreateForAppBroadcastOnly();
  }
}
