// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IUserDataPaths
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(4190451986, 43972, 18175, 138, 43, 220, 157, 127, 166, 229, 47)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (UserDataPaths))]
  internal interface IUserDataPaths
  {
    string CameraRoll { get; }

    string Cookies { get; }

    string Desktop { get; }

    string Documents { get; }

    string Downloads { get; }

    string Favorites { get; }

    string History { get; }

    string InternetCache { get; }

    string LocalAppData { get; }

    string LocalAppDataLow { get; }

    string Music { get; }

    string Pictures { get; }

    string Profile { get; }

    string Recent { get; }

    string RoamingAppData { get; }

    string SavedPictures { get; }

    string Screenshots { get; }

    string Templates { get; }

    string Videos { get; }
  }
}
