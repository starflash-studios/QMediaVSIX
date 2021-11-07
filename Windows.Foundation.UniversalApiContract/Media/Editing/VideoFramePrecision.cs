// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.VideoFramePrecision
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Editing
{
  /// <summary>Used to specify the frame precision algorithm when retrieving a thumbnail.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VideoFramePrecision
  {
    /// <summary>Use a more precise algorithm to get a thumbnail to the nearest frame.</summary>
    NearestFrame,
    /// <summary>Use a faster but less precise algorithm to get the thumbnail.</summary>
    NearestKeyFrame,
  }
}
