// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationPerson
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SyndicationPerson))]
  [Guid(4196328922, 42950, 17687, 160, 150, 1, 67, 250, 242, 147, 39)]
  internal interface ISyndicationPerson : ISyndicationNode
  {
    string Email { get; set; }

    string Name { get; set; }

    Uri Uri { get; set; }
  }
}
