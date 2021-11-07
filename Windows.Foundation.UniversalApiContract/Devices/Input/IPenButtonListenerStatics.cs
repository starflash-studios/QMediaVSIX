// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.IPenButtonListenerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [Guid(430482820, 34351, 24425, 191, 234, 5, 246, 88, 79, 19, 63)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (PenButtonListener))]
  internal interface IPenButtonListenerStatics
  {
    PenButtonListener GetDefault();
  }
}
