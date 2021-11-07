// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.ITappedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (TappedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3483444964, 9530, 19516, 149, 59, 57, 92, 55, 174, 211, 9)]
  internal interface ITappedEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    Point Position { get; }

    uint TapCount { get; }
  }
}
