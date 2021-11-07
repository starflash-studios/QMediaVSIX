// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapTypedValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [Guid(3447735465, 9283, 16384, 176, 205, 121, 49, 108, 86, 245, 137)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BitmapTypedValue))]
  internal interface IBitmapTypedValue
  {
    object Value { get; }

    PropertyType Type { get; }
  }
}
