// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapTypedValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>A value along with an enumeration specifying its data type.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IBitmapTypedValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class BitmapTypedValue : IBitmapTypedValue
  {
    /// <summary>Creates a new BitmapTypedValue object.</summary>
    /// <param name="value">The value to store.</param>
    /// <param name="type">The type of the *value* parameter.</param>
    [MethodImpl]
    public extern BitmapTypedValue(object value, PropertyType type);

    /// <summary>Gets the stored value.</summary>
    /// <returns>The stored value Object.</returns>
    public extern object Value { [MethodImpl] get; }

    /// <summary>Gets the PropertyType of the stored value.</summary>
    /// <returns>The PropertyType of the stored value.</returns>
    public extern PropertyType Type { [MethodImpl] get; }
  }
}
