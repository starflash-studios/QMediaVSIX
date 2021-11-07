// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.IErrorReportingSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Represents diagnostic error reporting settings.</summary>
  [Guid(372676498, 45118, 19361, 139, 184, 210, 143, 74, 180, 210, 192)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IErrorReportingSettings
  {
    /// <summary>Sets the type of error reporting for the error object.</summary>
    /// <param name="value">One of the enumeration values.</param>
    void SetErrorOptions(ErrorOptions value);

    /// <summary>Gets the type of error reporting for the error object.</summary>
    /// <returns>One of the enumeration values.</returns>
    ErrorOptions GetErrorOptions();
  }
}
