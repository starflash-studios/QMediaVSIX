// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.ILampArrayBitmapRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Devices.Lights.Effects
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (LampArrayBitmapRequestedEventArgs))]
  [Guid(3367284638, 65123, 19793, 186, 189, 97, 157, 239, 180, 84, 186)]
  internal interface ILampArrayBitmapRequestedEventArgs
  {
    TimeSpan SinceStarted { get; }

    void UpdateBitmap(SoftwareBitmap bitmap);
  }
}
