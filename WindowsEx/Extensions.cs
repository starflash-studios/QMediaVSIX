using System.Collections;
using System.Diagnostics.CodeAnalysis;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace WindowsEx {
	public static class Extensions {

		public static IEnumerable<T> GetEnumerator<T>( this IVectorView<T> VV ) {
			IIterator<T> Iterator = VV.First();
			while ( Iterator.MoveNext() ) { yield return Iterator.Current; }
		}

		public static Task<T> AsTask<T>( this IAsyncOperation<T> Op ) {
			TaskCompletionSource<T> TCS = new TaskCompletionSource<T>();

			void SetTaskResult( IAsyncOperation<T> S, AsyncStatus E ) {
				switch ( E ) {
					case AsyncStatus.Completed:
						TCS.TrySetResult(S.GetResults());
						break;
					case AsyncStatus.Canceled:
						TCS.TrySetCanceled();
						break;
					case AsyncStatus.Error:
						TCS.TrySetException(new Exception($"Async operation resulted in error '{S.ErrorCode}'."));
						break;
					default:
						throw new ArgumentException($"AsyncStatus return type '{E}' was unexpected at this time.", nameof(E));
				}
			}

			Op.Completed += SetTaskResult;
			return TCS.Task;
		}

		//

		public static void AddExceptionDataForRestrictedErrorInfo( this Exception E, string RestrictedError, string RestrictedErrorReference, string RestrictedCapabilitySid, object? RestrictedErrorObject, bool HasrestrictedLanguageErrorObject = false ) {
			IDictionary Dict = E.Data;
			if ( Dict != null ) {
				Dict.Add("RestrictedDescription", RestrictedError);
				Dict.Add("RestrictedErrorReference", RestrictedErrorReference);
				Dict.Add("RestrictedCapabilitySid", RestrictedCapabilitySid);

				// Keep the error object alive so that user could retrieve error information
				// using Data["RestrictedErrorReference"]
				Dict.Add("__RestrictedErrorObject", (RestrictedErrorObject == null ? null : new __RestrictedErrorObject(RestrictedErrorObject)));
				Dict.Add("__HasRestrictedLanguageErrorObject", HasrestrictedLanguageErrorObject);
			}
		}
	}

	[Serializable]
	[SuppressMessage("ReSharper", "InconsistentNaming")]
	[SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Reflection specific naming")]
	[SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "Suppression is necessary")]
	internal class __RestrictedErrorObject {
		// Hold the error object instance but don't serialize/deserialize it
		[NonSerialized]
		[SuppressMessage("Style", "IDE0044:Add readonly modifier", Justification = "Edited via reflection")]
		object _realErrorObject;

		internal __RestrictedErrorObject( object errorObject ) => _realErrorObject = errorObject;

		public object RealErrorObject => _realErrorObject;
	}

}