// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.IErrorDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ExclusiveTo(typeof (ErrorDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(931969793, 11465, 17039, 140, 85, 44, 153, 13, 70, 62, 143)]
  internal interface IErrorDetails
  {
    string Description { get; }

    string LongDescription { get; }

    Uri HelpUri { get; }
  }
}
