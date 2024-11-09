import React from 'react';

interface InputProps {
  value: string;
  onChange: (event: React.ChangeEvent<HTMLInputElement>) => void;
  type?: string;
  className?: string;
}

export const Input: React.FC<InputProps> = ({ value, onChange, type = 'text', className = '' }) => {
  return (
    <input
      type={type}
      value={value}
      onChange={onChange}
      className={`border p-2 rounded w-full ${className}`}
    />
  );
};
