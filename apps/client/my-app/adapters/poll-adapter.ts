import { Poll } from '@/models/poll-model';

export type PollAdapter = {
    id: number,
    name: string,
    voteAverage: number,
};

export function toPoll(adapter: PollAdapter): Poll {
    return {
        id: adapter.id,
        name: adapter.name,
        voteAverage: adapter.voteAverage,
    }
}