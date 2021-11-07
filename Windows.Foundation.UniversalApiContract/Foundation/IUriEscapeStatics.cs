// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IUriEscapeStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [Guid(3251909306, 51236, 17490, 167, 253, 81, 43, 195, 187, 233, 161)]
  [ExclusiveTo(typeof (Uri))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUriEscapeStatics
  {
    string UnescapeComponent(string toUnescape);

    string EscapeComponent(string toEscape);
  }
}
