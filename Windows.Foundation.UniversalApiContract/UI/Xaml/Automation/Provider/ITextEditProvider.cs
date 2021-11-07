// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ITextEditProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Extends the ITextProvider interface to support access by a Microsoft UI Automation client to controls that support programmatic text-edit actions. Implement ITextEditProvider in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.TextEdit.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3929408948, 14853, 16398, 181, 249, 78, 145, 180, 15, 97, 118)]
  public interface ITextEditProvider : ITextProvider
  {
    /// <summary>Gets the active composition.</summary>
    /// <returns>The active composition.</returns>
    ITextRangeProvider GetActiveComposition();

    /// <summary>Gets the current conversion target.</summary>
    /// <returns>The current conversion target.</returns>
    ITextRangeProvider GetConversionTarget();
  }
}
