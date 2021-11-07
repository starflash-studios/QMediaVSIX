// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.INumberRounderOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  /// <summary>An interface that gets and sets the option for rounding numbers.</summary>
  [Guid(990413875, 25711, 20222, 141, 72, 102, 235, 46, 73, 231, 54)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INumberRounderOption
  {
    /// <summary>Gets or sets the interface used to return rounded numbers.</summary>
    /// <returns>An interface for returning rounded numbers.</returns>
    INumberRounder NumberRounder { get; set; }
  }
}
