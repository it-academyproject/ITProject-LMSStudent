import { Topic } from '../topic/topic';

export interface Resource {
  id: number;
  name: string;
  description: string;
  file: string;
  topicId: number;
  topic: Topic[];
}