export type Poll = {
    id: number,
    name: string,
    voteAverage: number
}

export type CreatePoll = {
    name: string
}

export type AddVoteModel = {
    id: number,
    value: number
}