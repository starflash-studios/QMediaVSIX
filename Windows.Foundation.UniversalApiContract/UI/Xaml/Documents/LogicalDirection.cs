// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.LogicalDirection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  /// <summary>Specifies a logical direction in which to perform certain text operations, such as inserting, retrieving, or navigating through text relative to a specified position (a TextPointer ).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum LogicalDirection
  {
    /// <summary>Backward, or from right to left.</summary>
    Backward,
    /// <summary>Forward, or from left to right.</summary>
    Forward,
  }
}
