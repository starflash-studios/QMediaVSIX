// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.ILampArrayBitmapEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights.Effects
{
  [ExclusiveTo(typeof (LampArrayBitmapEffect))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(842588261, 55415, 17959, 137, 229, 42, 136, 247, 5, 47, 166)]
  internal interface ILampArrayBitmapEffect
  {
    TimeSpan Duration { get; set; }

    TimeSpan StartDelay { get; set; }

    TimeSpan UpdateInterval { get; set; }

    Size SuggestedBitmapSize { get; }

    event TypedEventHandler<LampArrayBitmapEffect, LampArrayBitmapRequestedEventArgs> BitmapRequested;
  }
}
