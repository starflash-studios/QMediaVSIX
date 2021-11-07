// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IRenderingDeviceReplacedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (RenderingDeviceReplacedEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(976333949, 10431, 20090, 133, 36, 113, 103, 157, 72, 15, 56)]
  internal interface IRenderingDeviceReplacedEventArgs
  {
    CompositionGraphicsDevice GraphicsDevice { get; }
  }
}
