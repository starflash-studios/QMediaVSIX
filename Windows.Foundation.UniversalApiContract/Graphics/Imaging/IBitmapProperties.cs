// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3936309019, 46341, 17488, 164, 209, 232, 202, 148, 82, 157, 141)]
  [ExclusiveTo(typeof (BitmapProperties))]
  internal interface IBitmapProperties : IBitmapPropertiesView
  {
    [RemoteAsync]
    IAsyncAction SetPropertiesAsync(
      IIterable<IKeyValuePair<string, BitmapTypedValue>> propertiesToSet);
  }
}
