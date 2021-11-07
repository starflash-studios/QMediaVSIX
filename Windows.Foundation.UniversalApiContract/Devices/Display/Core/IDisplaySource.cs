// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplaySource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;
using Windows.Storage.Streams;

namespace Windows.Devices.Display.Core
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (DisplaySource))]
  [Guid(3973144513, 60124, 20924, 151, 29, 59, 198, 40, 219, 45, 212)]
  internal interface IDisplaySource
  {
    DisplayAdapterId AdapterId { get; }

    uint SourceId { get; }

    IBuffer GetMetadata(Guid Key);
  }
}
