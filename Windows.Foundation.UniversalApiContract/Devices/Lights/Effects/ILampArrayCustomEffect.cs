// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.ILampArrayCustomEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights.Effects
{
  [Guid(3965161840, 15412, 18550, 129, 139, 87, 101, 247, 139, 14, 228)]
  [ExclusiveTo(typeof (LampArrayCustomEffect))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ILampArrayCustomEffect
  {
    TimeSpan Duration { get; set; }

    TimeSpan UpdateInterval { get; set; }

    event TypedEventHandler<LampArrayCustomEffect, LampArrayUpdateRequestedEventArgs> UpdateRequested;
  }
}
