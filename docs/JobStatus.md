
# PollinationSDK.Model.JobStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The ID of the individual job. | 
**StartedAt** | **DateTime** | The time at which the job was started | 
**Type** | **string** |  | [optional] [readonly] [default to "JobStatus"]
**Annotations** | **Dictionary&lt;string, string&gt;** | An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries. | [optional] 
**ApiVersion** | **string** |  | [optional] [readonly] [default to "v1beta1"]
**Status** | **JobStatusEnum** | The status of this job. | [optional] 
**Message** | **string** | Any message produced by the job. Usually error/debugging hints. | [optional] 
**FinishedAt** | **DateTime** | The time at which the task was completed | [optional] 
**Source** | **string** | Source url for the status object. It can be a recipe or a function. | [optional] 
**RunsPending** | **int** | The count of runs that are pending | [optional] [default to 0]
**RunsRunning** | **int** | The count of runs that are running | [optional] [default to 0]
**RunsCompleted** | **int** | The count of runs that have completed | [optional] [default to 0]
**RunsFailed** | **int** | The count of runs that have failed | [optional] [default to 0]
**RunsCancelled** | **int** | The count of runs that have been cancelled | [optional] [default to 0]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

