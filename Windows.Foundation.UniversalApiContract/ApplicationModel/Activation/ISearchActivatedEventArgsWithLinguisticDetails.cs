// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ISearchActivatedEventArgsWithLinguisticDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Search;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about the activated event that fires when an app is used to query text.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3231658970, 2219, 18737, 155, 124, 69, 16, 37, 242, 31, 129)]
  public interface ISearchActivatedEventArgsWithLinguisticDetails
  {
    /// <summary>Gets a SearchPaneQueryLinguisticDetails object that provides info about query text that the user enters through an Input Method Editor (IME).</summary>
    /// <returns>The object that provides info about query text.</returns>
    SearchPaneQueryLinguisticDetails LinguisticDetails { get; }
  }
}
