// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRightTappedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RightTappedEventArgs))]
  [Guid(1287602365, 44922, 18998, 148, 118, 177, 220, 225, 65, 112, 154)]
  internal interface IRightTappedEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    Point Position { get; }
  }
}
