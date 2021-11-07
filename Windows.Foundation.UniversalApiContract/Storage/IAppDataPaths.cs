// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IAppDataPaths
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(1929500170, 31138, 18633, 158, 192, 63, 218, 9, 47, 121, 225)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (AppDataPaths))]
  internal interface IAppDataPaths
  {
    string Cookies { get; }

    string Desktop { get; }

    string Documents { get; }

    string Favorites { get; }

    string History { get; }

    string InternetCache { get; }

    string LocalAppData { get; }

    string ProgramData { get; }

    string RoamingAppData { get; }
  }
}
