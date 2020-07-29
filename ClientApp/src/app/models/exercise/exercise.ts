import { Resource } from '../resource/resource';

export interface Exercise {
  id: number;
  availableTime: number;
  resourceId: number;
  resource: Resource[];
}