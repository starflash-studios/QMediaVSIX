// Decompiled with JetBrains decompiler
// Type: Windows.System.Display.IDisplayRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Display
{
  [Guid(3849527364, 62623, 19296, 141, 212, 94, 126, 58, 99, 42, 192)]
  [ExclusiveTo(typeof (DisplayRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDisplayRequest
  {
    void RequestActive();

    void RequestRelease();
  }
}
