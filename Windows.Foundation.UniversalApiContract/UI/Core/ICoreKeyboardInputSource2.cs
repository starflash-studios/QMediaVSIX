// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreKeyboardInputSource2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Guid(4196715412, 63843, 18341, 135, 120, 32, 124, 72, 43, 10, 253)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CoreComponentInputSource))]
  internal interface ICoreKeyboardInputSource2
  {
    string GetCurrentKeyEventDeviceId();
  }
}
