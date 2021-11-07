// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ISystemDataPaths
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(3811229552, 55546, 17900, 169, 66, 210, 226, 111, 182, 11, 165)]
  [ExclusiveTo(typeof (SystemDataPaths))]
  internal interface ISystemDataPaths
  {
    string Fonts { get; }

    string ProgramData { get; }

    string Public { get; }

    string PublicDesktop { get; }

    string PublicDocuments { get; }

    string PublicDownloads { get; }

    string PublicMusic { get; }

    string PublicPictures { get; }

    string PublicVideos { get; }

    string System { get; }

    string SystemHost { get; }

    string SystemX86 { get; }

    string SystemX64 { get; }

    string SystemArm { get; }

    string UserProfiles { get; }

    string Windows { get; }
  }
}
