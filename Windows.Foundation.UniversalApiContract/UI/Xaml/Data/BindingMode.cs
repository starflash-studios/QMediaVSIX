// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.BindingMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Describes how the data propagates in a binding.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum BindingMode
  {
    /// <summary>Updates the target property when the binding is created. Changes to the source object can also propagate to the target.</summary>
    OneWay = 1,
    /// <summary>Updates the target property when the binding is created.</summary>
    OneTime = 2,
    /// <summary>Updates either the target or the source object when either changes. When the binding is created, the target property is updated from the source.</summary>
    TwoWay = 3,
  }
}
