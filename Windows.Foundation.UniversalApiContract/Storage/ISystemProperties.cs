// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ISystemProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(2440720833, 34291, 19921, 176, 1, 165, 11, 253, 33, 200, 210)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SystemProperties))]
  internal interface ISystemProperties
  {
    string Author { get; }

    string Comment { get; }

    string ItemNameDisplay { get; }

    string Keywords { get; }

    string Rating { get; }

    string Title { get; }

    SystemAudioProperties Audio { get; }

    SystemGPSProperties GPS { get; }

    SystemMediaProperties Media { get; }

    SystemMusicProperties Music { get; }

    SystemPhotoProperties Photo { get; }

    SystemVideoProperties Video { get; }

    SystemImageProperties Image { get; }
  }
}
